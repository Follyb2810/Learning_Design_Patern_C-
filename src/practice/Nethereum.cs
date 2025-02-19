// using System;
// using System.Threading.Tasks;
// using Nethereum.Web3;
// using Nethereum.Contracts;
// using Nethereum.Hex.HexTypes;

//? https://github.com/Nethereum/Nethereum
//? dotnet add package Nethereum.Web3 

// class Program
// {
//     static async Task Main(string[] args)
//     {
//         // Initialize Web3 instance with your Ethereum node URL
//         string rpcUrl = "https://mainnet.infura.io/v3/YOUR_INFURA_PROJECT_ID";
//         var web3 = new Web3(rpcUrl);

//         // Smart contract ABI and address
//         string abi = @"[Your Contract ABI]";
//         string contractAddress = "0xYourContractAddress";

//         // Create a contract handler
//         var contract = web3.Eth.GetContract(abi, contractAddress);

//         // Call a constant function (e.g., getBalance)
//         var balanceFunction = contract.GetFunction("getBalance");
//         var balance = await balanceFunction.CallAsync<HexBigInteger>();
//         Console.WriteLine($"Balance: {balance.Value}");

//         // Send a transaction (e.g., deposit)
//         var depositFunction = contract.GetFunction("deposit");
//         string senderAddress = "0xYourSenderAddress";
//         string privateKey = "YOUR_PRIVATE_KEY";

//         var transactionInput = depositFunction.CreateTransactionInput(senderAddress, new HexBigInteger(1000000000000000000)); // 0.1 ETH
//         var signedTransaction = await web3.TransactionManager.SignTransactionAsync(senderAddress, transactionInput, privateKey);
//         var receipt = await web3.Eth.Transactions.SendRawTransactionAndWaitForReceiptAsync(signedTransaction);

//         Console.WriteLine($"Transaction Hash: {receipt.TransactionHash}");
//     }
// }