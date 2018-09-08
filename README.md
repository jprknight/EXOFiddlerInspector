# EXOFiddlerInspector
The Exchange Online Fiddler Inspector

Created in Visual Studio 2017 this inspector is intended to help with troubleshooting issues with Outlook and Office 365 / Exchange Online. Typically this inspector will be installed into Fidler and used to review traffic after reproducing an issue.

Project goals:

* Colourise sessions in session list. Highlight sessions of interest in typical traffic light style.
  * Red -- Expected to be HTTP 403 and HTTP 5xx response codes.
  * Orange -- Expected to be HTTP 401 unauthorised response codes. Something expected, though need to be accomanied by a subsequent authentication sucess in a HTTP 200 response.
  * Blue -- Expected to be anything which could be a false positive.
  * Green -- Expected to be anything which is given the all clear by the inspector.
  * Gray -- Expected to be anything which is not directly related to Outlook or Exchange.
* Add an inspector tab to show request and response information:
  * Request hostname, URL, type.
  * Response code, status code short description.
  * Request start and end, with duration.
  * Comments/alerts on sessions such as:
    * HTTP 403 Forbidden.
    * HTTP 502 Service Unavailable.
    * HTTP 200 Search for errors lurking in what are OK server responses.
  * Data freshness. Information on how old the trace is being looked at.
  
* More to come.