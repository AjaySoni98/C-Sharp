using System;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq;

namespace SQLBeginner{
     public class BankDetails{

         private int _acctno;
         private string _name;
         private string _bankname;
         private string _branch;

         public int AcctNo{
             get{
                 return this._acctno;
             }
             set{
                 this._acctno = value;
             }
         }

         public string Name{
             get{
                 return this._name;
             }
             set{
                 this._name = value;
             }
         }

         public string BankName{
             get{
                 return this._bankname;
             }
             set{
                 this._bankname = value;
             }
         }

         public string Branch{
             get{
                 return this._branch;
             }
             set{
                 this._branch = value;
             }
         }

         public BankDetails(int _acctno, string _name, string _bankname, string _branch){
             this._acctno = _acctno;
             this._name = _name;
             this._bankname = _bankname;
             this._branch = _branch;
         }

         public BankDetails (){}

     }
}