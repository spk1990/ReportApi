using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportApi.Models
{
public class Report
{
	public int Id { get; set; }

        
        public string? ReportName { get; set; }
        
        
        public string? Description { get; set; }
        
        
         public string? Body {get; set; }
        
        
        public Guid CreatedBy { get; set; }

        
        public DateTime CreatedDate { get; set; }

        
        public DateTime LastUpdatedDate { get; set; }

        public string? Category { get; set; }
        
}
}