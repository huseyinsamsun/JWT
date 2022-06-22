using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
  public  class ErrorDto
    {
        public bool IsShow { get; set; }
        public List<String> Errors { get; private set; }
        public ErrorDto()
        {
            Errors = new List<string>();
        }
        public ErrorDto(bool isShow, List<string> errors)
        {
            IsShow = isShow;
            Errors = errors;    
        }
        public ErrorDto(string error,bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }

    }
}
