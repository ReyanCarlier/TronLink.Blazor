export async function checkTronLink() {
  if (window.tronWeb && window.tronWeb.ready) {
    return true;
  } else {
    throw "NoTronLink";
  }
}

export function hasTronLink() {
  return (window.tronWeb && window.tronWeb.ready);
}

export async function getSelectedAddress() {
  if (!hasTronLink()) {
    throw "NoTronLink";
  } else {
    return window.tronWeb.defaultAddress.base58;
  }
}

export async function listenToChangeEvents(dotNetReference) {
  if (!hasTronLink()) {
    return;
  }
  window.tronWeb.on("addressChanged", function (accounts) {
    dotNetReference.invokeMethodAsync('OnAccountsChanged', accounts.base58);
  });
}

export async function getBalance(address) {
  if (!hasTronLink()) {
    throw "NoTronLink";
  } else {
    return await window.tronWeb.trx.getBalance(address);
  }
}

export async function sendTransaction(to, amount) {
  if (!hasTronLink()) {
    throw "NoTronLink";
  }
  const tradeobj = await window.tronWeb.transactionBuilder.sendTrx(to, amount, window.tronWeb.defaultAddress.base58);
  const signedtxn = await window.tronWeb.trx.sign(tradeobj);
  const receipt = await window.tronWeb.trx.sendRawTransaction(signedtxn);
  return receipt.txid;
}

export async function triggerSmartContract(contractAddress, functionSelector, parameters, options = {}) {
  if (!hasTronLink()) throw "NoTronLink";

  try {
    const contract = await window.tronWeb.contract().at(contractAddress);
    const result = await contract[functionSelector](...parameters).send(options);
    return result;
  } catch (error) {
    throw error;
  }
}

export async function listenToContractEvents(contractAddress, eventName, callback) {
  if (!hasTronLink()) throw "NoTronLink";

  const contract = await window.tronWeb.contract().at(contractAddress);
  contract[eventName]().watch((err, event) => {
    if (err) return console.error('Error during event listening:', err);
    callback(event);
  });
}
