using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using static PushNotif.Controllers.Notification;

namespace PushNotif.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CheckNotifController : ControllerBase
    {
        // POST: api/CheckNotif
        [HttpPost]
        public void notifAndroid ([FromBody] List<TargetNotif> targetNotif)
        {
            NotifAndroid notifAndroid = new NotifAndroid();
            notifAndroid.title = "Hay Iqbal !";
            notifAndroid.text = "Caca kangen ... ";

            SendNotif(targetNotif, notifAndroid.title, notifAndroid.text);
        }

       

        
    }
}
