using System;
using AElf.Types;

namespace AElf.WebApp.SDK.Web.Extension
{
    public static class TransactionResultStatusExtension
    {
        public static TransactionResultStatus ToTransactionResultStatus(this string status)
        {
            return (TransactionResultStatus) Enum.Parse(typeof(TransactionResultStatus), status, true);
        }
    }
}