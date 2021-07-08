using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGradeCalculator : MonoBehaviour
{

    /*Create a program that will calculate quiz grades for a student and return the average grade.Your program should support 5 quiz grades that are calculated randomly and based on the average print out either A, B, C or F.
    A = 90 - 100                                                                    
    B = 80 - 89                                                                                                            
    C = 70 - 79      
    F = < 70                                                                                                                         
    Bonus: Add support for unlimted quiz grades and create support to specify how many and automatically assign values to them and calculate the average grade.*/

    [SerializeField] private float[] _quizGrades;
    [SerializeField] private float _quizGradeAverage;
    [SerializeField] private int _numberOfQuizes;
    [SerializeField] private float _sum, _average;



    // Start is called before the first frame update
    void Start()
    {
       
        QuizGradeGenerator(_numberOfQuizes);
        QuizGradeAverage();

    }

    private void QuizGradeGenerator(int numberOfQuizes)
    {
        _quizGrades = new float[numberOfQuizes];
        for (int i = 0; i < numberOfQuizes; i++)
        {          
            float newNumber = Random.Range(65, 100);
            _quizGrades[i] = newNumber;
        }
    }

    private void QuizGradeAverage()
    {
        for(int i = 0; i < _quizGrades.Length; i++)
        {
            _sum += _quizGrades[i];
            
        }
        print(_sum);
        _average = _sum / _quizGrades.Length;
        print("Quiz Grade Average is : " + _average);

        if (_average >= 90)
        {
            print("Class Grade Averaage is 'A'");
        }
        else if(_average >= 80 && _average < 90)
        {
            print("Class Average is 'B'");
        }
        else if (_average >= 70 && _average < 80)
        {
            print("Class Garade Average is 'C'");
        }
        else
        {
            print("Class Grade Average is 'F'");
        }

    }


}
