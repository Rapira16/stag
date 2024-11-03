using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{

	public class GuestResponse
	{

		[Required(ErrorMessage = "Введите имя")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Введите почту")]
		[RegularExpression(".+\\@.+\\..+",
			ErrorMessage = "Некоректная почта. Пример: mailname@mail.ru")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Введите номер телефона")]
		[RegularExpression("^\\+?\\d{1,3}[-.\\s]?\\(?\\d{1,4}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$",
			ErrorMessage ="Некоректный номер телефона. Пример: +7 800 555 35 35")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Вы будете присутствовать или нет?")]
		public bool? WillAttend { get; set; }
	}
}