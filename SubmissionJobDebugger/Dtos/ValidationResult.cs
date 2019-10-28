using System.ComponentModel.DataAnnotations;

namespace SubmissionJobDebugger.Dtos
{
    public class ValidationResult
    {
        [Required]
        [Range(-1, 1)]
        public int Status { get; set; }

        [Required]
        public string ValidationToken { get; set; }

        public string Output { get; set; }

        public string Error { get; set; }
    }
}
