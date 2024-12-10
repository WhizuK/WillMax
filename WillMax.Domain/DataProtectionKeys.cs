using System;

namespace WillMax.Domain
{
    public record DataProtectionKeys(byte[] PasswordHash, byte[] PasswordSalt);
}