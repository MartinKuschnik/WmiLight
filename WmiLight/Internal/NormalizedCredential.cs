namespace WmiLight
{
    using System;
    using System.Diagnostics;
    using System.Net;

    internal class NormalizedCredential
    {
        internal NormalizedCredential(NetworkCredential networkCredential)
        {
            if (networkCredential.UserName != null)
            {
                string[] usernameParts = networkCredential.UserName.Split('\\');

                if (usernameParts.Length == 2)
                {
                    this.UserNameWithoutDomain = usernameParts[1];
                    this.UserNameWithDomain = networkCredential.UserName;

                    if (string.IsNullOrEmpty(networkCredential.Domain))
                        this.Domain = usernameParts[0];
                    else
                        this.Domain = networkCredential.Domain;
                }
                else
                {
                    usernameParts = networkCredential.UserName.Split('@');

                    if (usernameParts.Length == 2)
                    {
                        this.UserNameWithoutDomain = usernameParts[0];
                        this.UserNameWithDomain = networkCredential.UserName;

                        if (string.IsNullOrEmpty(networkCredential.Domain) || string.Equals(networkCredential.Domain, usernameParts[1], StringComparison.OrdinalIgnoreCase))
                            this.Domain = usernameParts[1];
                        else
                            this.Domain = networkCredential.Domain;

                    }
                    else
                    {
                        this.UserNameWithoutDomain = networkCredential.UserName;
                        this.UserNameWithDomain = string.IsNullOrEmpty(networkCredential.Domain) ? networkCredential.UserName : $"{networkCredential.Domain}\\{networkCredential.UserName}";
                        this.Domain = networkCredential.Domain;
                    }
                }
            }
            else
            {
                this.UserNameWithoutDomain = null;
                this.UserNameWithDomain = null;
                this.Domain = networkCredential.Domain;
            }

            this.Password = networkCredential.Password;
        }

        internal string UserNameWithoutDomain { get; }

        internal string UserNameWithDomain { get; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal string Password { get; }

        internal string Domain { get; }
    }
}
