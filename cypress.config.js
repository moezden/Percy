const { defineConfig } = require('cypress')

module.exports = defineConfig({
  e2e: {
    // Your project's URL
    baseUrl: 'http://localhost:8080',
    supportFile: false,

    // Paths to your integration test files
    specPattern: 'cypress/integration/**/*.cy.{js,jsx,ts,tsx}',

    // Path to your support files
    supportFile: 'cypress/support/index.js',

    // Path to your plugins file
    setupNodeEvents(on, config) {
      // implement node event listeners here
    },

    // Any additional configuration options
  },

  // Optionally include component testing configuration
  component: {
    // Configuration for component tests
  },

  // Other global configuration options
  video: false,
  // ...other configurations
})