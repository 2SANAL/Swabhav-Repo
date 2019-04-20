package com.teclabs.basic;

import java.util.Arrays;

public class Assignment1 {

	public static void main(String[] args) {
		String s = Arrays.toString(args);
		String[] str = s.split("[ @.,&?= ]");
		int index = 0;
		String name;
		while (index < str.length) {
			name=str[index];
			
			if (name.equals("[www")) {
				
				System.out.println("Company Name " + str[index + 1]);
				index++;
			} else if (name.equals("Developer")) {
				System.out.println("Deveopler " + str[index + 1]);
			} else if (name .equals("Location") ) {
				System.out.println("Location " + str[index + 1]);
			}
			index++;
		}

	}

}
