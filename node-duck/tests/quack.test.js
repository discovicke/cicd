import { quack } from "../src/quack.js";

describe.each([
  ["Kalle"],
  ["Donald"],
  ["Daisy"],
  [""],
  ["A very long duck name 123"],
])("quack(%p)", (name) => {
  test(`returns "${name} quacks!"`, () => {
    expect(quack(name)).toBe(`${name} quacks!`);
  });
});
