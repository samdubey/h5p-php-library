This folder contains the general H5P library. The files within this folder are not specific to any framework.

Any interaction with an LMS, CMS, or other frameworks is done through interfaces. Platforms need to implement
the H5PFrameworkInterface (in h5p.classes.php) and also do the following:

 - Provide a form for uploading H5P packages.
 - Place the uploaded H5P packages in a temporary directory.
 - Validate and move the H5P packages to the appropriate directory.
 - Implement content storage and retrieval.
 - Handle user permissions and roles.
 - Manage content dependencies and libraries.

See existing implementations for details. For instance, the Drupal H5P module located at drupal.org/project/h5p

We will make available documentation and tutorials for creating platform integrations in the future.

The H5P PHP library is GPL licensed due to GPL code being used for purifying HTML provided by authors.

## Usage Instructions

1. **Installation**:
   - Download the H5P library and place it in your project directory.
   - Implement the H5PFrameworkInterface in your platform.
   - Set up the necessary routes and controllers to handle H5P package uploads and interactions.

2. **Configuration**:
   - Configure your platform to use the H5P library by setting the appropriate paths and permissions.
   - Ensure that the temporary directory for H5P uploads is writable.

3. **Uploading H5P Packages**:
   - Provide a user interface for uploading H5P packages.
   - Use the H5P library functions to validate and move the uploaded packages to the correct location.

4. **Content Management**:
   - Implement functions to store and retrieve H5P content.
   - Manage user permissions to control who can upload, edit, and view H5P content.

5. **Dependencies and Libraries**:
   - Handle the inclusion of necessary H5P libraries and dependencies.
   - Ensure that all required libraries are available and correctly referenced.

## License

Open Sans font is licensed under Apache license, Version 2.0