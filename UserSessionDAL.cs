using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManagement
{
   public class UserSessionDAL
    {
       public string UpdateSession(string UserKey)
       {
           ObjectParameter SessionKey=new ObjectParameter("SessionID",typeof(string));
           try
           {
               var DbContext=new SessionDbContext();
               DbContext.Update_Session(UserKey,SessionKey);
           }
           catch (Exception ex)
           {
               string a = ex.Message;
           }
           return SessionKey.Value.ToString();
       }
    }
}
