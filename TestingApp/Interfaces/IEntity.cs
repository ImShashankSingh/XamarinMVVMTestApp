using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TestingApp.Interfaces
{
    public interface IEntity
    {
        int DbId { get; set; }
        //DateTime CreatedOn { get; set; }
        DateTime UpdatedLocallyOn { get; set; }
    }
}