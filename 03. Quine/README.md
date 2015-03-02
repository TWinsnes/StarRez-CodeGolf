# Write a quine (a program that prints out it's own source)
A Quine is a very interesting little program that does only one thing: it prints out exactly its own source code. Quines are tricky to write, but figuring out how to do it is a very rewarding and fun little challenge. 
Some rules for this challenge:
* The program can use no I/O except for printing out to standard output. It can't read (or write) anything from standard input, or any file (or network socket, or whatever). That is to say, you can't make a program that simply reads the source code and prints it out.
* The output of the program and the source code for the program have to match exactly, literally byte for byte (including newlines and comments, if you include any). If you're on a unix system, you can check for this by using the diff utility.
* The source code of your Quine has to be longer than 1 character. The reason for this is to prevent "degenerate" Quines, like having an empty program that prints out nothing.
* Often people compete about who can write the shortest Quine in a given programming language. Don't worry about that for this challenge, make your Quines as long as you want.
* No language that prints out itself by default, like php. Try to make it a challenge

## Input
None

## Output
The source code of the program exactly, byte for byte

## Bonus
Write a two language quine.

e.g.
$ python A.py > B.rb
$ ruby B.rb > C.py
$ diff A.py C.py

When running A, it will output B, that when ran will ouput C which is exactly the same as A