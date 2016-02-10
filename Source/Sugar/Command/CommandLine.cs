﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using Sugar.Extensions;

namespace Sugar.Command
{
    public class CommandLine
    {
        /// <summary>
        /// Gets the current process id.
        /// </summary>
        /// <returns></returns>
        public virtual int GetCurrentProcessId()
        {
            return Process.GetCurrentProcess().Id;
        }

        /// <summary>
        /// Gets the process ids of all currently running processes.
        /// </summary>
        /// <returns></returns>
        public virtual IList<int> GetProcessIds(string filename)
        {
            var results = new List<int>();

            var processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                if (CheckProcessFileName(process, filename))
                {
                    results.Add(process.Id);
                }
            }

            return results;
        }

        /// <summary>
        /// Checks to see if the file name of the process matches the given file name.
        /// </summary>
        /// <param name="process">The process.</param>
        /// <param name="match">The match.</param>
        /// <returns></returns>
        public bool CheckProcessFileName(Process process, string match)
        {
            bool result;

            try
            {
                var fileName = process.MainModule.FileName;

                fileName = Path.GetFileName(fileName);

                result = string.Compare(fileName, match, StringComparison.InvariantCultureIgnoreCase) == 0;
            }
            catch (Win32Exception)
            {
                // Ignore this process - no access rights
                result = false;
            }
            catch (InvalidOperationException)
            {
                // Ignore this process - no access rights
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Gets the current process's command line.
        /// </summary>
        /// <returns></returns>
        public string GetCommandLine()
        {
            return GetCommandLine(GetCurrentProcessId());
        }

        /// <summary>
        /// Gets the command line for the process with the given id.
        /// </summary>
        /// <param name="processId">The process id.</param>
        /// <returns></returns>
        public virtual string GetCommandLine(int processId)
        {
            var result = string.Empty;

            var query = $"SELECT CommandLine FROM Win32_Process WHERE ProcessId = {processId}";

            using (var searcher = new ManagementObjectSearcher(query))
            {
                foreach (var @object in searcher.Get())
                {
                    result = @object["CommandLine"] as string;

                    result = CleanUpCommandLine(result);

                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Strips the filename from the command line.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public string CleanUpCommandLine(string input)
        {
            var result = string.Empty;

            if (!string.IsNullOrEmpty(input))
            {
                if (input.StartsWith(@""""))
                {
                    // After 2nd quote
                    result = input.SubstringAfterChar(@"""").SubstringAfterChar(@"""").Trim();
                }
                else
                {
                    result = input.SubstringAfterChar(" ");
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the command lines for all running processes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<int, string> GetCommandLines(string filename)
        {
            var results = new Dictionary<int, string>();

            var processIds = GetProcessIds(filename);

            foreach (var processId in processIds)
            {
                var commandLine = GetCommandLine(processId);

                results.Add(processId, commandLine);
            }

            return results;
        }

        /// <summary>
        /// Determines if a process with the current command line is already running.
        /// </summary>
        /// <remarks>
        /// Processes with empty command lines are always allowed.
        /// </remarks>
        /// <returns></returns>
        public bool AlreadyRunning(string filename)
        {
            var result = false;

            var currentCommandLine = GetCommandLine();
            var commandLines = GetCommandLines(filename);

            // Always allow empty args (interactive mode)
            if (string.IsNullOrEmpty(currentCommandLine))
            {
                return false;
            }

            // Check currently running command lines
            foreach (var commandLine in commandLines)
            {
                // Ignore current process
                if (commandLine.Key == GetCurrentProcessId()) continue;

                // Skip non-matching command lines
                if (string.Compare(currentCommandLine, commandLine.Value, StringComparison.OrdinalIgnoreCase) != 0) continue;

                // Already running!
                result = true;
                break;
            }

            return result;
        }

        /// <summary>
        /// Outputs the specified value to the system console with the current date-time.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Write(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("{0:yyyy-MM-dd HH:mm:ss} : ", DateTime.UtcNow);
            Console.ResetColor();

            if (!string.IsNullOrEmpty(value))
            {
                Console.Write(value);
            }
        }

        /// <summary>
        /// Outputs the line to the system console.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteLine(string value)
        {
            Write(value);
            Console.WriteLine();
        }
    }
}
