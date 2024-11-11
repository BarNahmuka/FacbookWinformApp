# Facebook WinForm

Facebook WinForm is a Windows application developed using C#, the .NET framework, and WinForms. 
This application integrates with the Facebook API, enabling users to log in, view profile details, and interact with photos and posts. 
In this enhanced edition, new features offer an engaging user experience, while design patterns ensure a modular, maintainable, and user-friendly interface.

## About

The Enhanced Facebook WinForm provides users with a feature-rich Facebook experience that goes beyond standard API interactions:

- Slide Show: Displays a randomized slideshow of user photos, creating a nostalgic journey through memories.
- Advanced Search: Allows users to find friends with specific shared interests (such as Liked Pages and events) within a selected age range. 
  This feature has a dedicated FormAdvancedSearch form, streamlining searches for mutual interests.
- Sound Manager: Each user can set a unique theme song for their profile, offering a personalized audio experience when navigating between profiles.
- User Identification: Streamlines profile identification within the app, adding a layer of personalization.
- Albums and Collections: Provides organized views of the user's albums and other collections via FormAlbums and FormFacebookCollection forms, allowing structured exploration of media and posts.

## Methodology and Design Patterns

The Enhanced Facebook WinForm application is built with Object-Oriented Programming (OOP) principles, emphasizing modularity, flexibility, and maintainability. 
A range of design patterns has been applied to create a well-structured, scalable codebase. 
Here are the key design patterns utilized in this project:

### Factory Method
To streamline the creation of forms for various object types, reducing redundancy and simplifying updates.
The CollectionFormFactory class leverages an enum (eCollectionFormType) to generate specific forms based on user actions in FormMain. 
This design reduces the need for multiple unique form classes, providing a flexible and scalable form creation process.

### Adapter
To modularize the retrieval and display of user profile details, allowing for easy extension to include additional data types.
The adapter class retrieves and formats the About section of the user's profile as a list of strings (e.g., groups, pages) accessed through a facade. 
This design supports flexible data retrieval and consistent presentation, ensuring modularity in profile display.

### Facade
To simplify interactions between the UI and the core application logic, promoting modularity and maintainability by reducing direct dependencies.
The facade class is instantiated lazily, with logical components structured as members.
This setup allows the UI to access functionality transparently, ensuring a clean interface between the UI and core logic components.

### Singleton
To manage the Sound Manager as a single instance, ensuring consistent behavior when playing music across profiles.
The SoundManager class follows the Singleton pattern, allowing only one instance, which is protected by a lock to prevent multiple instantiations. This ensures uniform audio management as users navigate different profiles.
Multithreading
Multithreading is applied in FormMain to improve responsiveness. The FetchData method runs separate threads for each data request, allowing the UI to load while data retrieval continues in the background. This technique reduces loading delays and enhances the user experience by making interactions smoother and faster.

Data Binding
Data binding is utilized in FormAdvancedSearch, linking the UI elements to underlying data sources. 
This ensures dynamic updates based on user selections, providing real-time visual feedback and making data interactions more intuitive.
