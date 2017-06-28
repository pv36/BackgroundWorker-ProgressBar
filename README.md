# BackgroundWorker-ProgressBar

Simple vb.net example using a BackgroundWorker to execute an Async Task (send mail button)
The BackgroundWorker reports back to a ProgressBar that is updated accordingly
Finally a message is appended to a text box saying thath the AsyncTask is finished.
There is another button (another procedure) with synchronous execution appending 
a message to the textbox so you ensure that send mail function works asynchronously.

** note that send mail button is just a simulation using Thread.Sleep and not an actual mail method
