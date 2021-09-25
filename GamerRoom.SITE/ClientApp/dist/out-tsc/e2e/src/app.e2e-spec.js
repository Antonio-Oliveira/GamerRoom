import { AppPage } from './app.po';
describe('App', () => {
    let page;
    beforeEach(() => {
        page = new AppPage();
    });
    it('should display welcome message', () => {
        page.navigateTo();
        expect(page.getMainHeading()).toEqual('Hello, world!');
    });
});
//# sourceMappingURL=app.e2e-spec.js.map