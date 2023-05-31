using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Pschool.Shared.DTOs;

namespace Pschool.Client
{
    public class AppState
    {
        public ParentDto? Parent { get; set; }
        public StudentDto? Student { get; set; }      
    }
}
