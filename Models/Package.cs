using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewProject.Models;

public class Package
{
	public int Id { get; set; }
	
	[Required]
	[StringLength(512)]
	public string? Description { get; set; }
	
	
	[Required]
	[Column(TypeName = "REAL")]
	[Range(0.01, Double.MaxValue, ErrorMessage = "Invalid maximal weight (must be greater than 0.01)")]
	public decimal Weight { get; set; }
	
	[Required]
	public DateTime CreatedDate { get; set; }
	
	public Plane? Plane{ get; set;}
	
}