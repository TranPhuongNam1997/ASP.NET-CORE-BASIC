using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    [Route("khach-hang")]
    public class CustomerController : Controller
    {
        [Route("vip")]
        public string vip()
        {
            return "khach hàng vip";
        }

        // nếu đặt route rỗng cũng vào normal

        [Route("")]
        [Route("normal/{id?}")]
        public string normal(int id)
        {
            return "khach hang thuong co id:" + id;
        }


    }
}