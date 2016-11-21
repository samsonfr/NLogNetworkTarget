# NLogNetworkTarget
A simple application to test NLog targets

It contains:

- A simple Windows Forms application with a lone button. Clicking it will add entry to the log for every available log levels.
- A sample NLog configuration with 3 targets: File, NLogViewer and Chainsaw. The last one will broadcast the log using the UDP protocol.
- You can install Log2Console or Sentinel to view logs generated from NLogViewer and Chainsaw.

I created a dedicated (french only) blog article on this subject:
https://samsonfr.wordpress.com/2016/11/18/comment-journaliser-dans-un-flux-udp-visible-du-rseau-local-avec-nlog/

Frederick
