using System.ComponentModel.DataAnnotations;

namespace CarServices.Core.Models
{
    public class PagenationSettingsModel
    {
        [Required(ErrorMessage = "Размер страницы должен быть установлен")]
        [Range(1, 100, ErrorMessage = "Cтраница должна содержать от 1 до 100 записей")]
        public int PageSize { set; get; }
        [Required(ErrorMessage = "Номер запрашиваемой страницы должен быть установлен")]
        [Range(1, int.MaxValue, ErrorMessage = "Номер станицы должен быть как минимум равен 1")]
        public int PageNumber { set; get; }
    }
}
