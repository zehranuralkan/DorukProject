using DorukProject.Models;
using DorukProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DorukProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReportService _reportService;
        private readonly ITableColumnsService _tableColumns;


        public HomeController(ILogger<HomeController> logger, IReportService reportService, ITableColumnsService tableColumns)
        {
            _logger = logger;
            _reportService = reportService;
            _tableColumns = tableColumns;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Raporları getiren method
        /// </summary>
        [HttpGet]
        [Route("Home/GetReport")]
        public List<ReportViewModel> GetReport()
        {
            var result = _reportService.GetReport();
            return result;
        }
        /// <summary>
        /// Tablonun sutun degerlerini getirir
        /// </summary>
        [HttpGet]
        [Route("Home/GetTableColumns")]
        public List<string> GetTableColumns()
        {
            var result = _tableColumns.GetTableColumns();
            return result;
        }

    }
}