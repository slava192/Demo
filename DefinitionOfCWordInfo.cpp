// DefinitionOfMethodsOfCWordInfo.cpp
// Определение всех методов класса CWordInfo
#pragma once
#include <iostream> 
#include <iomanip> 
#include <string.h> 
#include <assert.h> 
#include "DefinitionOfCWordInfo.h"

// конструктор
CWordInfo::CWordInfo (int _ID, int _ParentID, int _Position, char* _Original, char* _NF, char* _Alphabet, char* _WordCase, char* _Pos, char* _SyntacticFunction, char* _SurfaceSlot, char* _ExtendedLexicalClass, char* _Stem, char* _Punctuators, char* _Person,char* _Case, int _Number, char* _Animateness,char* _Gender, char* _NounType, char* _Tense,char* _Mood, char* _Voice, char* _VerbTransitivity, char* _VerbForm, char* _ObjectLocalization,char* _SemanticRelation, char* _PolarityAndDirection, char* _Inchoative, char* _IsConjuctedWith, char* _DegreeOfComparison, char* _ChildOfCollocation,char* _RootOfCollocation, int  _NumericValue, char* _Emotionality, CCtrlID* _pControllerID)
{  setID(_ID);
   setParentID(_ParentID);
   setPosition(_Position);
   setNumber(_Number);
   setNumericValue(_NumericValue);
   setOriginal(_Original);
   setNF(_NF);
   setAlphabet(_Alphabet);
   setWordCase(_WordCase);
   setPos(_Pos);
   setSyntacticFunction(_SyntacticFunction);
   setSurfaceSlot(_SurfaceSlot);
   setExtendedLexicalClass(_ExtendedLexicalClass);
   setStem(_Stem);
   setPunctuators(_Punctuators);
   setPerson(_Person);
   setCase(_Case);
   setAnimateness(_Animateness);
   setGender(_Gender);
   setNounType(_NounType);
   setTense(_Tense);
   setMood(_Mood);
   setVoice(_Voice);
   setVerbTransitivity(_VerbTransitivity);
   setVerbForm(_VerbForm);
   setObjectLocalization(_ObjectLocalization);
   setSemanticRelation(_SemanticRelation);
   setPolarityAndDirection(_PolarityAndDirection);
   setInchoative(_Inchoative);
   setIsConjuctedWith(_IsConjuctedWith);
   setDegreeOfComparison(_DegreeOfComparison);
   setChildOfCollocation(_ChildOfCollocation);
   setRootOfCollocation(_RootOfCollocation);
   setEmotionality(_Emotionality);
   setControllerID (_pControllerID);
}

// конструктор копии
CWordInfo::CWordInfo(const CWordInfo &copy)
{   
}

// деструктор
CWordInfo::~CWordInfo()
{	// delete [ ] Original;
    // delete [ ] NF;
}

// перегруженная операция "="
const CWordInfo &CWordInfo::operator=(const CWordInfo &right) 
{ 
	if (&right != this) { //проверка самоприсваивания 
		//------------------------------- 
	} else { // попытка самоприсваивания 
       return *this; // обеспечивает возможность сцепленных присваиваний 
      }
}

// перегруженная операция "=="
//int CWordInfo::operator== (const CWordInfo &right) const 
//{
   //-------------------------------------
//} 

// перегруженная операция "!="
//int CWordInfo::operator!=(const CWordInfo &right) const 
//{ 
//	return (*this == right) ? 0 : 1;
//} 

// Set ID
void CWordInfo::setID(int _ID)
{	ID=_ID;
}
// Get ID
int CWordInfo::getID() const 
{	return ID;
}

// Set ParentID
void CWordInfo::setParentID(int _ParentID)
{	ParentID=_ParentID;
}
// Get ParentID
int CWordInfo::getParentID() const
{	return ParentID;
}

// Set Position
void CWordInfo::setPosition(int _Position)
{	Position=_Position;
}
// Get Position
int CWordInfo::getPosition() const
{	return Position;
}

// Set Number
void CWordInfo::setNumber(int _Number)
{	Number=_Number;
}
// Get Number
int CWordInfo::getNumber() const 
{	return Number;
}

// Set NumericValue
void CWordInfo::setNumericValue(int _NumericValue)
{	NumericValue=_NumericValue;
}
// Get NumericValue
int CWordInfo::getNumericValue() const 
{	return NumericValue;
}

// Set Original
void CWordInfo::setOriginal(char* _Original)
{	Original=_Original;
}
// Get Original
char* CWordInfo::getOriginal() const 
{	return Original;
}

// Set NF
void CWordInfo::setNF(char* _NF)
{	NF=_NF;
}
// Get NF
char* CWordInfo::getNF() const 
{	return NF;
}

// Set Alphabet
void CWordInfo::setAlphabet(char* _Alphabet)
{	Alphabet=_Alphabet;
}
// Get Alphabet
char* CWordInfo::getAlphabet() const 
{	return Alphabet;
}

// Set WordCase
void CWordInfo::setWordCase(char* _WordCase)
{	WordCase=_WordCase;
}
// Get WordCase
char* CWordInfo::getWordCase() const 
{	return WordCase;
}

// Set Pos
void CWordInfo::setPos(char* _Pos)
{	Pos=_Pos;
}
// Get Pos
char* CWordInfo::getPos() const 
{	return Pos;
}

// Set SyntacticFunction
void CWordInfo::setSyntacticFunction(char* _SyntacticFunction)
{	SyntacticFunction=_SyntacticFunction;
}
// Get SyntacticFunction
char* CWordInfo::getSyntacticFunction() const 
{	return SyntacticFunction;
}

// Set SurfaceSlot
void CWordInfo::setSurfaceSlot(char* _SurfaceSlot)
{	SurfaceSlot=_SurfaceSlot;
}
// Get SurfaceSlot
char* CWordInfo::getSurfaceSlot() const 
{	return SurfaceSlot;
}

// Set ExtendedLexicalClass
void CWordInfo::setExtendedLexicalClass(char* _ExtendedLexicalClass)
{	ExtendedLexicalClass=_ExtendedLexicalClass;
}
// Get ExtendedLexicalClass
char* CWordInfo::getExtendedLexicalClass() const 
{	return ExtendedLexicalClass;
}

// Set Stem
void CWordInfo::setStem(char* _Stem)
{	Stem=_Stem;
}
// Get Stem
char* CWordInfo::getStem() const 
{	return Stem;
}

// Set Punctuators
void CWordInfo::setPunctuators(char* _Punctuators)
{	Punctuators=_Punctuators;
}
// Get Punctuators
char* CWordInfo::getPunctuators() const 
{	return Punctuators;
}

// Set Person
void CWordInfo::setPerson(char* _Person)
{	Person=_Person;
}
// Get Person
char* CWordInfo::getPerson() const 
{	return Person;
}

// Set Case
void CWordInfo::setCase(char* _Case)
{	Case=_Case;
}
// Get Case
char* CWordInfo::getCase() const 
{	return Case;
}

// Set Animateness 
void CWordInfo::setAnimateness(char* _Animateness)
{	Animateness=_Animateness;
}
// Get Animateness
char* CWordInfo::getAnimateness() const 
{	return Animateness;
}

// Set Gender
void CWordInfo::setGender(char* _Gender)
{	Gender=_Gender;
}
// Get Gender
char* CWordInfo::getGender() const 
{	return Gender;
}

// Set NounType
void CWordInfo::setNounType(char* _NounType)
{	NounType=_NounType;
}
// Get NounType
char* CWordInfo::getNounType() const 
{	return NounType;
}

// Set Tense
void CWordInfo::setTense(char* _Tense)
{	Tense=_Tense;
}
// Get Tense
char* CWordInfo::getTense() const 
{	return Tense;
}

// Set Mood
void CWordInfo::setMood(char* _Mood)
{	Mood=_Mood;
}
// Get Mood
char* CWordInfo::getMood() const 
{	return Mood;
}

// Set Voice
void CWordInfo::setVoice(char* _Voice)
{	Voice=_Voice;
}
// Get Voice
char* CWordInfo::getVoice() const 
{	return Voice;
}

// Set VerbTransitivity
void CWordInfo::setVerbTransitivity(char* _VerbTransitivity)
{	VerbTransitivity=_VerbTransitivity;
}
// Get VerbTransitivity
char* CWordInfo::getVerbTransitivity() const 
{	return VerbTransitivity;
}

// Set VerbForm
void CWordInfo::setVerbForm(char* _VerbForm)
{	VerbForm=_VerbForm;
}
// Get VerbForm
char* CWordInfo::getVerbForm() const 
{	return VerbForm;
}

// Set ObjectLocalization
void CWordInfo::setObjectLocalization(char* _ObjectLocalization)
{	ObjectLocalization=_ObjectLocalization;
}
// Get ObjectLocalization
char* CWordInfo::getObjectLocalization() const 
{	return ObjectLocalization;
}

// Set SemanticRelation
void CWordInfo::setSemanticRelation(char* _SemanticRelation)
{	SemanticRelation=_SemanticRelation;
}
// Get SemanticRelation
char* CWordInfo::getSemanticRelation() const 
{	return SemanticRelation;
}

// Set PolarityAndDirection
void CWordInfo::setPolarityAndDirection(char* _PolarityAndDirection)
{	PolarityAndDirection=_PolarityAndDirection;
}
// Get PolarityAndDirection
char* CWordInfo::getPolarityAndDirection() const 
{	return PolarityAndDirection;
}

// Set Inchoative
void CWordInfo::setInchoative(char* _Inchoative)
{	Inchoative=_Inchoative;
}
// Get Inchoative
char* CWordInfo::getInchoative() const 
{	return Inchoative;
}

// Set IsConjuctedWith
void CWordInfo::setIsConjuctedWith(char* _IsConjuctedWith)
{	IsConjuctedWith=_IsConjuctedWith;
}
// Get IsConjuctedWith
char* CWordInfo::getIsConjuctedWith() const 
{	return IsConjuctedWith;
}

// Set DegreeOfComparison
void CWordInfo::setDegreeOfComparison(char* _DegreeOfComparison)
{	DegreeOfComparison=_DegreeOfComparison;
}
// Get DegreeOfComparison
char* CWordInfo::getDegreeOfComparison() const 
{	return DegreeOfComparison;
}

// Set ChildOfCollocation
void CWordInfo::setChildOfCollocation(char* _ChildOfCollocation)
{	ChildOfCollocation=_ChildOfCollocation;
}
// Get ChildOfCollocation
char* CWordInfo::getChildOfCollocation() const 
{	return ChildOfCollocation;
}

// Set RootOfCollocation
void CWordInfo::setRootOfCollocation(char* _RootOfCollocation)
{	RootOfCollocation=_RootOfCollocation;
}
// Get RootOfCollocation
char* CWordInfo::getRootOfCollocation() const 
{	return RootOfCollocation;
}

// Set Emotionality
void CWordInfo::setEmotionality(char* _Emotionality)
{	Emotionality=_Emotionality;
}
// Get Emotionality
char* CWordInfo::getEmotionality() const 
{	return Emotionality;
}


// Set ControllerID
void CWordInfo::setControllerID (CCtrlID* _pControllerID)
{	ControllerID= new CCtrlID;
	ControllerID->type=_pControllerID->type;
    ControllerID->original=_pControllerID->original;
	ControllerID->ID=_pControllerID->ID;
}
// Get ControllerID
CCtrlID* CWordInfo::getControllerID() const 
{	return ControllerID;
}