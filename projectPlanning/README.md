# Project Planning
> Note: Post and "Knowledge Item" are synonymous
## Planned Features
- [ ] Landing Page
  - [ ] Button to navigate to authoring page
  - [ ] Button to navigate to search/browsing page
  - [ ] Search bar - search for specific things / categories of things I learned
    - [ ] Clicking search button/ hitting enter navigates to Browsing page with relevant search results
  - [ ] Display of one random historical thing I learned (knowledge)
    - [ ] Clicking historical knowledge navigates to relevant knowledge page
  - [ ] Random display of encouraging (or random humorous) quotes
- [ ] Authoring Page
  - [ ] Textbox to add short title
  - [ ] Textbox to add brief description
  - [ ] Textfield to add optional extended description/blogpost in Markdown
    - [ ] live Markdown preview should be available
      - [ ] checkbox to show/hide markdown preview
  - [ ] Add external learning sources
  - [ ] Buttons to commit content, save current content, cancel (return to browsing page)
    - [ ] Clicking Commit content button should navigate to Knowledge page
- [ ] Browsing Page
  - [ ] Search bar - search for specific things / categories of things I learned
    - [ ] Clicking search button/hitting enter generates search results list
      - [ ] Search results listings feature only Title and short description
        - [ ] Some indication of whether extended description exists
        - [ ] Display metatags
- [ ] Knowledge Page
  - [ ] Display Title, short description, and long description/blogpost if appropriate
  - [ ] Display metatags
  - [ ] Display list of external learning sources
  - [ ] Button to edit Knowledge
  - [ ] Button to delete Knowledge
- [ ] Header
  - [ ] Logo, TIL title
  - [ ] Searchbar
    - [ ] Clicking search button/ hitting enter navigates to Browsing page with relevant search results
- [ ] Footer
  - [ ] Built by Nicholas Ho, Github link
- [ ] Aesthetics
  - [ ] Minimalist, simple.
  - [ ] Primary colours
  - [ ] Sans Serif font
  - [ ] White Background
  - [ ] header and footer thin, unintrusive

## API
- [x] route stubs
- [ ] `/api/posts?q=<searchTerms>`
  - [ ] GET: Returns list of knowledge items that match search terms
  - [ ] POST: Adds title, short description, long description, metadata, external learning data to DB
- [ ] `/api/posts/[id]`
  - [ ] GET: Returns title, short description, long description, metadata, external learning data
  - [ ] PUT: Edits title, short description, long description, metadata, external learning data in DB
  - [ ] DELETE: Deletes title, short description, long description, metadata, external learning data from DB
- [ ] `/api/posts/latest`
  - [ ] GET: Returns latest knowledge item that was made
- [ ] `/api/posts/random`
  - [ ] GET: Returns random knowledge item
- [ ] `api/quotes/random`
  - [ ] GET: Returns a random quote to display on landing page

## DB
Joins not really required, NoSQL may be a good choice to start with.
- Posts
```JSON
{
  "_id": ObjectID,
  "title": String,
  "description": String,
  "blogpost:": String,
  "tags": String[],
  "externalInfo": {
    "urls": String[],
    "other": String[]
  }
}
```
- Quotes
```JSON
{
  "_id": ObjectID,
  "author": String,
  "date": DateTime
  "quote": String
}
```

## CI/CD
- [ ] Github Actions
  - [ ] TBA