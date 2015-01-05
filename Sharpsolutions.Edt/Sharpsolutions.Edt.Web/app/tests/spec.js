// spec.js
describe('angularjs homepage', function () {
    it('should have a title', function () {
        browser.get('https://localhost:44300/edt/app');

        expect(browser.getTitle()).toEqual('Elite: Dangerous - Trading App');
    });
});