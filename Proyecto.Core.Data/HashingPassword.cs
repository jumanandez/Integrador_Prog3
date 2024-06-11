﻿using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Data
{
	public static class HashingPassword
	{
		
		 public static byte[] HashPassword(string password, byte[] salt)
		{
			using (var sha256 = new SHA256Managed())
			{
				byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
				byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

				// Concatenate password and salt
				Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
				Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

				// Hash the concatenated password and salt
				byte[] hashedBytes = sha256.ComputeHash(saltedPassword);

				// Concatenate the salt and hashed password for storage
				byte[] hashedPasswordWithSalt = new byte[hashedBytes.Length + salt.Length];
				Buffer.BlockCopy(salt, 0, hashedPasswordWithSalt, 0, salt.Length);
				Buffer.BlockCopy(hashedBytes, 0, hashedPasswordWithSalt, salt.Length, hashedBytes.Length);

				return hashedPasswordWithSalt;
			}
		}

		 public static byte[] GenerateSalt()
		{
			using (var rng = new RNGCryptoServiceProvider())
			{
				byte[] salt = new byte[16]; // Adjust the size based on your security requirements
				rng.GetBytes(salt);
				return salt;
			}
		}
	}
}

