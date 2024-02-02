using System;

namespace DJ
{
    class Choose
    {
        public string _prompt;
        public string _response;
        public string _date;

        public Choose(string prompt, string response, string date)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
        }

        public string GetPrompt()
        {
            return _prompt;
        }

        public string GetResponse()
        {
            return _response;
        }

        public string GetDate()
        {
            return _date;
        }

        public override string ToString()
        {
            return $"Date: {_date} - Prompt: {_prompt} {_response}";
        }
    }
}
