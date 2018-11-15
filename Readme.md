<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ThreadedSkinning/Form1.cs) (VB: [Form1.vb](./VB/ThreadedSkinning/Form1.vb))
* [Form2.cs](./CS/ThreadedSkinning/Form2.cs) (VB: [Form2.vb](./VB/ThreadedSkinning/Form2.vb))
* [Program.cs](./CS/ThreadedSkinning/Program.cs) (VB: [Program.vb](./VB/ThreadedSkinning/Program.vb))
<!-- default file list end -->
# How to keep a look and feel of Windows forms in sync


<p>After opening a form in a new thread you may notice that it doesn't follow the Look and Feel settings of your main application form. The reason for this is that each thread possesses its own <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressLookAndFeelDefaultLookAndFeeltopic">DefaultLookAndFeel</a> instance, for it is marked with the <a href="http://msdn.microsoft.com/en-us/library/system.threadstaticattribute.aspx">ThreadStatic</a> attribute in our code. Knowing this fact leads to the necessity of synchronizing DefaultLookAndFeel instances from different threads. This example demonstrates a possible solution of synchronizing Look and Feel settings in threaded forms.</p><p><strong>See also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/K18013">What is the best way to set the same Look-and-Feel style of the entire application with DXperience for Windows Forms?</a></p>

<br/>


