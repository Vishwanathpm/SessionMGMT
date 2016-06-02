using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManagement
{
   public class UserSessionBAL
    {
       public string InsertSession(string UserID)
       {
           string SessionKey = string.Empty;
           try
           {
               UserSessionDAL objSessionDAL = new UserSessionDAL();
               SessionKey = objSessionDAL.UpdateSession(UserID);
           }
           catch (Exception ex)
           {
               string a = ex.Message;
           }
           return SessionKey;
       }
    }
}
