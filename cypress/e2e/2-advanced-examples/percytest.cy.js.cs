import '@percy/cypress';
namespace DefaultNamespace;

public class percytest_cy_js
{
    import '@percy/cypress';

    describe('Integration test with visual testing', function() {
        it('Loads the homepage', function() {
            // Load the page or perform any other interactions with the app.
            cy.visit(www.google.de);
            // Take a snapshot for visual diffing
            cy.percySnapshot();
        });
    });
}