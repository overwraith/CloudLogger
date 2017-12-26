/*Author: Cameron Block*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;

namespace CloudLogger {

    /// <summary>
    /// Log cloud application events to single cloud computer. 
    /// </summary>
    public class CloudLoggerModule : NancyModule {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("CloudLogger");

        /// <summary>
        /// Constructor cloud logger module. 
        /// </summary>
        public CloudLoggerModule() : base("/CloudLogger") {
            Post["/Debug/{message}"] = parameters => { return Debug(parameters.message); };
            Post["/Error/{message}"] = parameters => { return Error(parameters.message); };
        }//end method

        /// <summary>
        /// Log multiple computers to a single location on the network. 
        /// </summary>
        /// <param name="message"></param>
        public bool Debug(String message) {
            try {
                log.Debug(message);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }//end method

        /// <summary>
        /// Log error messages from multiple locations to a single computer on the network. 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Error(String message) {
            try {
                log.Error(message);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }//end method

    }//end class

}//end namespace