using System;
using System.Collections.Generic;
using System.Text;

namespace EventPortal.Models
{
    public class Constants
    {
        public const string FetchEventsUrl = "http://www.jacnepal.com/php_rest_myblog/api/post/read.php";
        public const string SaveEventUrl = "http://www.jacnepal.com/php_rest_myblog/api/post/create.php";
        public const string FetchSingleUserUrl = "http://www.jacnepal.com/php_rest_myblog/api/user/read_single.php?Username=";
        public const string SaveNewUserUrl = "http://www.jacnepal.com/php_rest_myblog/api/user/create.php";

    }
}
