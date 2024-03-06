using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace CabApp.API
{
    public static class JwtTokenGenerator
    {

        public static string GenerateToken(List<Claim> claims)
        {
            //getting the key and changing it into bytes.
            //key should be in byte only

            var secret = "Batman is not really a bat and may be not even a cat";
            var key = Encoding.ASCII.GetBytes(GenerateKeyName(secret));

            //it will contains token information
            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512)
            };

            //It will Create the jwt token for us
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);


            //change and return the token as string
            return tokenHandler.WriteToken(token);
        }

        
        public static string GenerateKeyName(string phrase)
        {
            // Step 1: Create an acronym to distill entropy from the phrase
            string[] words = phrase.Split(' ');

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    sb.Append(word[0]); // Take the first letter of each word
                }
            }

            //from this line to the last help to create the key . We are using SHA512 Algorithm.


            // Step 2: Convert the acronym into a byte array
            byte[] nameBytes = Encoding.UTF8.GetBytes(sb.ToString());


            // Step 3: Hash the bytes to ensure a 512-bit length - it is giving 512 bit lenght to bytes
            using (SHA512 shaM = SHA512.Create())
            {
                byte[] hashBytes = shaM.ComputeHash(nameBytes);


                // Step 4: (Optional) Convert the hash to a Base64 string for use as a key name
                string keyName = Convert.ToBase64String(hashBytes);

                return keyName;
            }
        }
    }
}
