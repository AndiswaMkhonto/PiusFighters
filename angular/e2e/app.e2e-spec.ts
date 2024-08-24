import { MonkeyAndRiverTemplatePage } from './app.po';

describe('MonkeyAndRiver App', function() {
  let page: MonkeyAndRiverTemplatePage;

  beforeEach(() => {
    page = new MonkeyAndRiverTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
