<a name="readme-top"></a>

<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://clearinsights.io">
    <img src="https://clearinsights.io/wp-content/uploads/2022/05/wp-logo-2.png" alt="Logo" width="235" height="38">
  </a>
  <br />
  <br />

  <h2 align="center">ClearInsights.Console</h3>

  <p align="center">
    An example of how to use the ClearInsights SDK within your .Net Console applications and services.
    <br /><br />
    <a href="https://docs.clearinsights.io"><strong>Explore the docs »</strong></a>
    <br />
    <br />    
    <a href="https://github.com/ClearInsights/ClearInsights.Console/issues">Report Bug</a>
    ·
    <a href="https://clearinsights.io/contact-us/">Request Feature</a>
  </p>
</div>

<br />
<br />


<!-- GETTING STARTED -->
## Getting Started



### Prerequisites

_Install the ClearInsights SDK_
* Package Manager
  ```sh
  Install-Package ClearInsights -Version 1.0.42
  ```
* .Net CLI
  ```sh
  dotnet add package ClearInsights --version 1.0.42
  ```

### Installation

_Create a free ClearInsights account to start using the SDK_

1. Get a free account at [https://clearinsights.io](https://clearinsights.io) and retrieve your API Key under the Administration ->APIKey menu.

2. Create at least 1 product and 1 environment and retrieve the Client Secret for the product/environment.

3. Clone the repo
   ```sh
   git clone https://github.com/ClearInsights/ClearInsights.Console.git
   ```

4. Enter your API Key and Client Secret in `Program.cs`
   ```js
   .AddClearInsightsLogger(configuration =>
            {
                configuration.ApiKey = "{ApiKey}";
                configuration.Secret = "{Environment Client Secret}";
                configuration.ApplicationName = "{Application Name}";
            }))
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Use this app as an example of how to use the ClearInsights SDK within your console applications and services.

_For more examples, please refer to the [Documentation](https://docs.clearinsights.io)_

<p align="right">(<a href="#readme-top">back to top</a>)</p>

