<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2033)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyDetailsWorker.cs](./CS/WinWebSolution.Module/MyDetailsWorker.cs) (VB: [MyDetailsWorker.vb](./VB/WinWebSolution.Module/MyDetailsWorker.vb))
<!-- default file list end -->
# OBSOLETE - How to implement Controller or Action that will be active only in the "My Details" window


<p><strong>===============================</strong><br /><strong>This example is now obsolete. Instead, use the built-in <a href="https://documentation.devexpress.com/#Xaf/CustomDocument3307">CurrentUserId</a>  criteria function.</strong><br /><strong>===============================</strong><br /><br />This example shows how to implement a ViewController, containing Actions, that will be active only in the "My Details" window.<br /> In order to do this, we will set the <a href="http://documentation.devexpress.com/#Xaf/DevExpressExpressAppActionsActionBase_TargetViewIdtopic">TargetViewId</a> property either of the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2621">ViewController</a> or <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2622">Action</a> objects at design time. Take special note that this Id will vary against the type of the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2647">Security System</a> (<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2767">Simple</a> or <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2768">Complex</a>) used in the application, because there are different user types for them.<br /> To solve this problem in a more elegant way, we will also configure an Action at runtime, but set its properties against the properties of the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2769">SecuritySystem</a> singleton.</p>
<p><strong>See Also:</strong><br /> <a href="https://www.devexpress.com/Support/Center/p/K18055">How to remove or hide (deactivate, disable) a button ( Action ) from tool bar</a><br /> <a href="http://documentation.devexpress.com/#Xaf/DevExpressExpressAppActionsActionBase_TargetObjectsCriteriatopic">ActionBase.TargetObjectsCriteria</a></p>

<br/>


