import '@percy/cypress';
namespace DefaultNamespace;

public class percytest_cy_js
{
    import '@percy/cypress';

    describe('Integration test with visual testing', function() {
        it('Loads the homepage', function() {
            // Load the page or perform any other interactions with the app.
            cy.visit(www.ikrabau.de);
            // Take a snapshot for visual diffing
            cy.percySnapshot('IKRA Homepage', { widths: [768, 992, 1200] });
        });
    });
}