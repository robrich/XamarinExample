Creating Cross Platform Apps with Xamarin Studio
================================================

Here's an example project from the [Windows 8 App Factor](http://www.windows8appfactor.com/events/) event in Tempe on June 13th, 2013.
I presented "Creating Cross Platform Apps with Xamarin Studio."

The methodology for building these apps is pretty straight forward once you've groked the approach.

![Xamarin Development Methodology](ConceptualArchitecture.png)

- The majority of your application logic lives in a central library project using [Portable Class Libraries](http://www.hanselman.com/blog/CrossPlatformPortableClassLibrariesWithNETAreHappening.aspx)
- A project per platform contains a thin interface layer that calls into the common libraries

If the common business logic needs to call into native content, consume an interface defined in the common library, and use Dependency Injection to inject in the corresponding platform-specific implimentation.

In this sample application is a central library, and an Android, Windows Phone 8, and Windows Store consuming application.
Note the elegance of the Android designer from within Visual Studio.

Also is a second solution that uses the MVVM design pattern to make the presentation tier even thinner.
The presentation tier need only impliment the view's interface and instantiate the model.