﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteliTroco.Core.Logger {
	
	public interface ILogger {

		void Log(LevelType level, CategoryType category, object data);
	}
}
