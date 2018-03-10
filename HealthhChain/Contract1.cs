using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System.Threading;

namespace HealthhChain
{
    public class Healtchain : SmartContract
    {

        public static string Main (string operation, params object[] args)
        {
            byte[] owner = new byte[] {3, 170, 248, 27, 24, 22, 58, 190, 139, 28, 40, 137, 161, 69, 248, 236, 2, 254, 14, 33, 64, 179, 125, 97, 228, 195, 118, 119, 5, 60, 148, 150, 238 };
            switch (operation)
            {
                case "register":
                case "delegate": 
                    Storage.Put(Storage.CurrentContext, (byte[]) args[0], (byte[])args[1]);
                    return "Master have been added";
                case "stopDelegate":
                     Storage.Delete(Storage.CurrentContext, (byte[])args[0]);
                    return "Master have been deleted";
                default:
                    return "Method not found";
            }
        }
    }
}