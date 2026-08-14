\# AI Reflection — Day 1



Claude was useful for identifying the pricing logic as the messiest part of `OrderService` and proposing a Strategy Pattern. I agreed with separating bulk-quantity discounts and membership discounts because the existing method had two independent pricing rules. I also kept the pricing order explicit through dependency injection, because changing the order could change the final price. I caught that the pricing engine needed to be a real dependency of `OrderService` rather than being manually constructed inside the service; otherwise the design would make testing and dependency injection weaker.



I would have caught a bug if the refactor changed the order in which discounts were applied. The original code applied the bulk discount first and the membership discount second, so reversing the strategies would produce different totals. I verified the implementation and ran the existing tests before committing the refactor.



Copilot saved time by generating repetitive test setup for negative and zero quantities. I still reviewed its suggestions against the actual service code instead of assuming the generated assertions were correct. The negative-quantity test was appropriate because the service explicitly rejects quantities less than or equal to zero. The important lesson was that generated tests can still make assumptions, so I checked the expected status code and error message before accepting them.



At 2 AM IST debugging production, I would reach for Claude first for understanding a large or unfamiliar piece of code, but I would rely on tests and the actual diff before trusting any generated change. Copilot was faster for repetitive test code, while Claude was more useful for the larger structural refactor.