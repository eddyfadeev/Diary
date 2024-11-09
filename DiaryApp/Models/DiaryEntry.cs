using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models;

public class DiaryEntry
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please enter a title for the entry")] 
    [StringLength(100, MinimumLength = 3, 
        ErrorMessage = "Title must be between 3 and 100 characters")]
    public string Title { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter how was your day")]
    [StringLength(100)]
    public string Content { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please, specify the date of the entry")] 
    public DateTime Created { get; set; } = DateTime.Now;
}

