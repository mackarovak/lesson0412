using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework
{
	class Account
	{
		public enum AccountType
		{ 
			Current,
		    Savings 
		}
		private int index;
		private Type accountType;
		private double balance;
		static int index1 = 0;

		public Account()
		{
			index = index1++;
		}

		public Account(double balance)
		{
			index = index1++;
			this.balance = balance;
		}

		public Account(Type accountType)
		{
			index = index1++;
			this.accountType = accountType;
		}

		public Account(Type accountType, double balance) : this(accountType)
		{
			this.balance = balance;
		}

		public bool Draw(double summa)
		{
			if (summa <= balance)
			{
				balance -= summa;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool Put(double summa)
		{
			if (summa > 0)
			{
				balance += summa;
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool MakeTransfer(Account receiver, double summa)
		{
			if (Draw(summa))
			{
				receiver.Put(summa);
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool operator ==(Account account1, Account account2)
        {
			return account1.accountType == account2.accountType && account1.balance == account2.balance;
        }
		public static bool operator !=(Account account1, Account account2)
		{
			return !(account1.accountType == account2.accountType && account1.balance == account2.balance);
		}
        public override bool Equals(object obj)
        {
			if (obj is Account) { return this == (obj as Account); }
			else return false;
        }
        public void Dispose(string file)
		{
			StreamWriter sw = new StreamWriter(file);
			sw.Close();
			GC.SuppressFinalize(sw);
		}
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
			return $"{index},{accountType},{balance}";
        }
    }
}
