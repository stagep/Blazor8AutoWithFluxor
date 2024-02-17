This application demonstrates the InteractiveAuto render mode when using Fluxor. The server and client Blazor applications use the same shared Counter state code. However, the server and client will each create their own instance of the Counter state.

In a real world application, an InteractiveAuto rendered page will use InteractiveServer rendering and then switch to InteractiveWebAssembly rendering at a later time.

In a simple application, the InteractiveAuto page will switch to InteractiveWebAssembly immediately. This example allows you to control the InteractiveAuto rendering mode that will be used initially by the Counter Auto page.

To have the InteractiveAuto page use InteractiveServer rendering, first select Counter Server from the NavBar and increment the count. Next, select Counter Auto from the NavBar and notice that the current count remains the same.

To have the InteractiveAuto page use InteractiveWebAssembly rendering, first select Counter WebAssembly from the NavBar and increment the count. Next, select Counter Auto from the NavBar and notice that the current count remains the same.

If you stay on a page being rendered with InteractiveWebAssembly for a few seconds and return to the Counter Server page, you will see that the current count is now zero. This has occured because the channel to the server was closed and the Fluxor state on the server was lost. Select the Counter Auto page and notice that the Counter Auto page is now using InteractiveServer rendering again.

In a real world scenario using InteractiveAuto rendering, when the page switches from InteractiveServer to InteractiveWebAssembly, the Fluxor state will switch from the server state to the client state. This application does not demonstrate any mechanism that could be used to persist the state from the server to the client.
