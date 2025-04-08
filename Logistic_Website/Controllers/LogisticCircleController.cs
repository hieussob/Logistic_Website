using Logistic_Website.Models;
using Logistic_Website.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Logistic_Website.Controllers
{
    public class LogisticCircleController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Suggest = GetSuggestUser();
            return View();
        }

        public IActionResult News()
        {
            return PartialView("_News");
        }

        public IActionResult PortCircle()
        {
            var model = GetPortCircle();
            return PartialView("_PortCircle", model);
        }

        public IActionResult Review()
        {
            return PartialView("_Review");
        }

        public IActionResult ServiceCircle()
        {
            var model = GetServiceCircle();
            return PartialView("_ServiceCircle", model);
        }

        private List<Circle> GetPortCircle()
        {
            return
            [
                new()
                {
                    Name = "Hải Phòng",
                    Descreption = "Vòng tròn giao nhận Hải Phòng",
                    PeopleJoinCount = 25500,
                    ThreadCount = 9864,
                },
                new()
                {
                    Name = "Quảng Ninh",
                    Descreption = "Vòng tròn giao nhận Quảng Ninh",
                    PeopleJoinCount = 29500,
                    ThreadCount = 11456,
                },
                new()
                {
                    Name = "Đã Nẵng",
                    Descreption = "Vòng tròn giao nhận Đà Nẵng",
                    PeopleJoinCount = 17500,
                    ThreadCount = 12789,
                },
                new()
                {
                    Name = "Hồ Chí Minh",
                    Descreption = "Vòng tròn giao nhận Hồ Chí Minh",
                    PeopleJoinCount = 31000,
                    ThreadCount = 19764,
                },
                new()
                {
                    Name = "Nội Địa",
                    Descreption = "Vòng tròn giao nhận nội địa",
                    PeopleJoinCount = 419234,
                    ThreadCount = 234827,
                },
                new()
                {
                    Name = "Hải Phòng",
                    Descreption = "Vòng tròn giao nhận Vũng Tàu",
                    PeopleJoinCount = 12834,
                    ThreadCount = 8348,
                },
            ];
        }

        private List<Circle> GetServiceCircle()
        {
            return
            [
                new()
                {
                    Name = "CHÂU ÂU",
                    Descreption = "Vòng tròn giao nhận Châu Âu",
                    PeopleJoinCount = 25500,
                    ThreadCount = 9864,
                },
                new()
                {
                    Name = "ĐÔNG NAM Á",
                    Descreption = "Vòng tròn giao nhận Đông Nam Á",
                    PeopleJoinCount = 29500,
                    ThreadCount = 11456,
                },
                new()
                {
                    Name = "hàng nguy hiểm",
                    Descreption = "Vòng vận chuyển hàng nguy hiểm",
                    PeopleJoinCount = 17500,
                    ThreadCount = 12789,
                },
                new()
                {
                    Name = "hàng cỡ lớn đặc biệt",
                    Descreption = "Vòng vận chuyển hàng cỡ lớn đặc biệt",
                    PeopleJoinCount = 3234,
                    ThreadCount = 986,
                },
                new()
                {
                    Name = "LCL Châu Mỹ - Latinh",
                    Descreption = "Vòng tròn LCL Châu Mỹ - Latinh",
                    PeopleJoinCount = 419234,
                    ThreadCount = 234827,
                },
                new()
                {
                    Name = "ONE",
                    Descreption = "Hãng tàu ONE",
                    PeopleJoinCount = 12834,
                    ThreadCount = 8348,
                },
            ];
        }

        private List<UserInfor> GetSuggestUser()
        {
            return
            [
                new()
                {
                    Name = "Nguyễn Ngọc Huyền",
                    Decreption = "CÔNG TY TNHH SHIPCO TRANSPORT VIỆT NAM",
                    Image = "NguyenNgocHuyenAvatar.png",
                },
                new()
                {
                    Name = "Lê Thị Ngọc",
                    Decreption = "Công ty TNHH Thương mại Dịch vụ xuất nhập khẩu Timex",
                    Image = "LeThiNgocAvatar.png",
                },
                new()
                {
                    Name = "Nam Dương Nguyễn",
                    Decreption = "Công Ty TNHH Cảng Nam Hải Đình Vũ",
                    Image = "NamDuongNguyenAvatar.png",
                },
                new()
                {
                    Name = "Nguyễn Thị Hồng",
                    Decreption = "Công  ty Cổ phần Chuỗi cung ứng TTL",
                    Image = "NguyenThiHongAvatar.png",
                },
            ];
        }
    }
}
