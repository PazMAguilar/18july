def enclose_keywords(rule: str, keywords: list) -> str:
    pass


if __name__ == '__main__':
    bnf_rule: str = "(Alice | The Red Queen | The Queen | White Rabbit) (said ((wait for|follow) me) | ate (" \
                    "cake|cookies) | saw (a (carrot|tree))| fell [down a  hole]) (angrily | quietly)"
    bnf_keywords: list = ['cake']
    print(enclose_keywords(bnf_rule, bnf_keywords))
