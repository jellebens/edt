using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api.Models.Core {
	public class JobResult {
		public bool HasError { get; set; }
		public bool IsComplete { get; set; }
		public bool InProgress { get; set; }
	}
}