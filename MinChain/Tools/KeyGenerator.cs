using Newtonsoft.Json;
using System;

namespace MinChain
{
    public class KeyGenerator
    {
        public static void Exec(string[] args)
        {
            byte[] publicKey;
            byte[] privateKey;
            EccService.GenerateKey(out privateKey, out publicKey);

            var keyPair = new KeyPair
            {
                PrivateKey = privateKey,
                PublicKey = publicKey,
                Address = BlockchainUtil.ToAddress(publicKey),
            };
            var json = JsonConvert.SerializeObject(keyPair, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
