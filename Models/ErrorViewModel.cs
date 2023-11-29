using System;

namespace Model_Binding_2___Modelde_Belirli_Alanları_Doldurmak.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
