# Software Tests

**Manual Tests**
- Performed by human tester.

**Unit Tests**
- To check small unit of code.

**Integration Tests**
- Integration testing is the process of testing the interface between two software units or modules. 

**End-To-End Tests**
- For many applicaitons, we design End-To-End tests as an automated version of manual tests.
- One of the most popular tool for that is Selenium (for web apps only).

**Performance/Load Tests**
- To check if the program can handle a heavy load.

**Smoke Test**
- They cover the core functionality of the app.
- They runs before a more extensive suit of tests or before the app is handed over to the manual testers.

**Regression tests**
- Designed specifically to verify if the code changes did not break any existing functionality.
- Usually created when the code already exists, and we are getting ready for some changes, for example, major refactoring.

<img width="496" alt="image" src="https://github.com/user-attachments/assets/773bdfdf-054c-40e2-8487-c09e43db61d7">

# Test-Driven-Development
Test-driven development (TDD) is a way of writing code that involves writing an automated unit-level test case that fails, then writing just enough code to make the test pass, then refactoring both the test code and the production code, then repeating with another new test case.

# Unit Testing
- Unit test is an automated test that verifies if a single unit of a program works as expected.
- A single uint is the smallest peice of code that can be logically isolated in a program.
- Usually, it is a single method in a class.

**Manual Tests vs Automated Tests**
<table>
	<tbody>
		<tr>
			<th>Manual Tests</th>
			<th>Automated Tests</th>
		</tr>
		<tr>
			<td> Performed by human tester.</td>
			<td>No need for a human tester.</td>
		</tr>
		<tr>
			<td>Slow and laborious.</td>
			<td>Fast Running.</td>
		</tr>
		<tr>
			<td>Require many tester(Expensive).</td>
			<td>Inexpensive to run.</td>
		</tr>
		<tr>
			<td>Risk of omitting a test.</td>
			<td>No risk of omitting a test.</td>
		</tr>
		<tr>
			<td>Result: Fear of changes.</td>
			<td>Result: No fear of changes.</td>
		</tr>
	</tbody>
</table>

**Unit Tests**
- Unit tests are code just like any other.
- It is very important to keep them in good shape.
- High quality unit tests server as documentation.

**AAA**
- AAA stands for Arrange, Act, and Assert.
- It describe three steps every test should contain.

**Problem with Unit Testing**
- Writing unit tests is not an easy job.
- They need to be adjusted as the code changes.
- Adding unit tests is a serious time investment.
- Most modern software companies require unit tests to be written for the majority of code they produce.

**Benefit of unit tests**
- They given us confident that the code works as expected.
- We can run them easily and effortlessly.
- With unit tests, we are not afraid to refactor the code.

** Without Refactoring**
- The quality of the code degrades over time.
- Adding functionality changes gets harder.
- Adding functionality changes get more expensive.
- The developer get frustated (and may leave).

**Downside of unit tests**
- They test units of code, not the system as a whole.
- They take time and effort to be developed and maintained.
- The may be implemented incorrectly and produce misleading results.
- They may give us a false sense of security.

**Poor quality of unit tests**
- Each change takes longer.
- Temptation to stop writing unit tests.
- Developer's frustation.

**White Box Tests Vs Black Box Tests**
<table>
	<tbody>
		<tr>
			<th>White Box Tests</th>
			<th>Black Box Tests</th>
		</tr>
		<tr>
			<td>Unit tests are white box tests.</td>
			<td>Manual tests are black box tests.</td>
		</tr>
		<tr>
			<td>They are aware of implementation details of program.</td>
			<td>They are not aware of implementation details of program.</td>
		</tr>
	</tbody>
</table>
