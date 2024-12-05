using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;

namespace InterviewProject.Models;

public class Plane
{
	public int? Id { get; set; }
	
	[Required]
	[Range(100, Int32.MaxValue, ErrorMessage = "Invalid identification number (at least three digits expected)")]
	public int IdentificationNumber { get; set; }
	
	
	[Required]
	[Column(TypeName = "REAL")]
	[Range(1.0, Double.MaxValue, ErrorMessage = "Invalid maximal weight (must be greater than 1.0)")]
	public decimal MaxWeight { get; set; }
	
	public virtual ICollection<Package> Packages { get; set; } = new List<Package>();
	
	public decimal getTotalWeight(){
		return this.Packages.Sum(p => p.Weight);
	}
}