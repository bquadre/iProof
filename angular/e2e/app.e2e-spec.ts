import { iProofTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: iProofTemplatePage;

  beforeEach(() => {
    page = new iProofTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
