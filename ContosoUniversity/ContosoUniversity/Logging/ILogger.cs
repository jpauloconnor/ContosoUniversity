using System;

namespace ContosoUniversity.Logging
{
    public interface ILogger
    {
        /// <summary>
        /// 1-4
        /// A bunch of overloads here. 
        /// Provides 3 tracing levels to indiciate importance of logs
        /// One designed to provide latency ino for extrenal service class
        /// Overloads allow exceptions to be pass in.
        /// 4. Enables you to track the latency of each call to an external service(SQL database)
        /// </summary>
        /// <param name="message"></param>
        
            //1
        void Information(string message);
        void Information(string fmt, params object[] vars);
        void Information(Exception exception, string fmt, params object[] vars);
        
            //2 
        void Warning(string message);
        void Warning(string fmt, params object[] vars);
        void Warning(Exception exception, string fmt, params object[] vars);

            //3
        void Error(string message);
        void Error(string fmt, params object[] vars);
        void Error(Exception exception, string fmt, params object[] vars);

            //4 
        void TraceApi(string componentName, string method, TimeSpan timespan);
        void TraceApi(string componentName, string method, TimeSpan timespan, string properties);
        void TraceApi(string componentName, string method, TimeSpan timespan, string fmt, params object[] vars);
    }
}